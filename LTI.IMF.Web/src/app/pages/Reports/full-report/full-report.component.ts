import { Component, ViewChild, OnInit, HostListener } from '@angular/core';
import 'rxjs/add/operator/debounceTime';
import { MatDialog, MatPaginator, MatSort, MatTableDataSource } from '@angular/material';
import { NgBlockUI, BlockUI } from 'ng-block-ui';
import { Router } from "@angular/router";
import { ToastrService } from 'ngx-toastr';
import { saveAs } from 'file-saver';
import { DashboardService } from '../../../services/dashboard.service';
import { Country } from '../../../Models/Country';
import { PeriodicElement } from '../../../Models/PeriodicElement';
import { FullReport } from '../../../Models/full-report';
import { Column } from '../../../Models/Column';
import { MasterDataService } from '../../../services/MasterData.service';
import { DatePipe } from '@angular/common';

import * as jspdf from 'jspdf'
import 'jspdf';
import 'jspdf-autotable';
import * as FileSaver from 'file-saver';
import * as XLSX from 'xlsx';

import { Chart } from 'chart.js';
import * as moment from 'moment';

const EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
const EXCEL_EXTENSION = '.xlsx';

@Component({
    selector: 'app-full-report',
    templateUrl: './full-report.component.html',
    styleUrls: ['./full-report.component.css']
})
export class FullReportComponent implements OnInit {
    @BlockUI() blockUI: NgBlockUI
    countries: any[];

    @ViewChild("paginator1") paginator1: MatPaginator;
    @ViewChild("paginator2") paginator2: MatPaginator;
    @ViewChild("paginator3") paginator3: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;

    datalist: any = [];

    obj: any = {};
    bShowChart: boolean = false;

    //countriesList: Country[]; 
    categoryList: any;
    countryList: any;
    yearList: any;
    selectedCountries = [];
    selectedYears = [];
    selectedCategories = [];
    reportData = [];
    reportType: string;
    isFullReport: boolean = false;
    isYesIndexReport: boolean = false;
    isChangeIndexReport: boolean = false;
    isPaging: boolean = false;


    ELEMENT_DATA: PeriodicElement[] = [
        { position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H' },
        { position: 2, name: 'Helium', weight: 4.0026, symbol: 'He' },
        { position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li' },
        { position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be' },
        { position: 5, name: 'Boron', weight: 10.811, symbol: 'B' },
        { position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C' },
        { position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N' },
        { position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O' },
        { position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F' },
        { position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne' },
    ];
    //displayedColumnsPeriodicElement: string[] = ['position', 'name', 'weight', 'symbol'];
    displayedColumnsPeriodicElement: string[] = [];
    displayedColumnsYesIndex: string[] = [];
    displayedColumnsChangeIndex: string[] = [];
    dataSourcePeriodicElement = new MatTableDataSource([]);
    dataSourceYesIndex = new MatTableDataSource([]);
    dataSourceChangeIndex = new MatTableDataSource([]);



    constructor(
        private dashboardService: DashboardService,
        public masterDataService: MasterDataService,
        private router: Router,
        private toastr: ToastrService,
        public dialog: MatDialog,
        private datePipe: DatePipe
    ) {

    }

    ngOnInit() {

        console.log("Dashboard");
        this.masterDataService.getCountries().subscribe((data: any) => {
            // this.countries = data;
            this.countryList = data.countries;
            this.categoryList = data.categories;
            this.yearList = data.years;
            console.log(data);
        });


    }

    getReport() {

        let countries = this.selectedCountries.join(",");
        let categories = this.selectedCategories.join(",");
        let years = this.selectedYears.join(",");
        console.log(countries);

        let filterCriteria = {
            countryCodeIds: countries,
            categoryCodeIds: categories,
            years: years,
            months: '1, 2, 3, 4, 5, 6',
            reportType: this.reportType

        }

        /* var filterCriteria = {
           countryCodeIds: '37, 95',
           categoryCodeIds: '1, 2, 3, 4',
           years: '2010',
           months: '1, 2, 3, 4, 5, 6'
       }
       */
        console.log(this.reportType);
        this.displayedColumnsPeriodicElement = [];
        this.displayedColumnsYesIndex = [];
        this.displayedColumnsChangeIndex = [];
        this.dataSourcePeriodicElement = new MatTableDataSource([]);
        this.dataSourceYesIndex = new MatTableDataSource([]);
        this.dataSourceChangeIndex = new MatTableDataSource([]);
        this.isPaging = true;


        this.dashboardService.getFullReport(filterCriteria).subscribe((data: FullReport[]) => {
            if (this.reportType == "fullReport") {
                this.displayedColumnsPeriodicElement = ['countryCode', 'countryName', 'year', 'monthName', 'categoryName', 'indicator'];

                this.dataSourcePeriodicElement = new MatTableDataSource(data);
                this.dataSourcePeriodicElement.sort = this.sort;
                this.dataSourcePeriodicElement.paginator = this.paginator1;
                this.isFullReport = true;
                this.isYesIndexReport = false;
                this.isChangeIndexReport = false;


            }
            if (this.reportType == "yesIndexReport") {
                this.displayedColumnsYesIndex = ['countryCode', 'countryName', 'year', 'monthName', 'YesIndex'];

                this.dataSourceYesIndex = new MatTableDataSource(data);
                this.dataSourceYesIndex.sort = this.sort;
                this.dataSourceYesIndex.paginator = this.paginator2;
                this.isFullReport = false;
                this.isYesIndexReport = true;
                this.isChangeIndexReport = false;

                this.dashboardService.getReportChart(filterCriteria).subscribe((data: any) => {
                    console.log(data);
                    var stackedLine = new Chart('canvas', {
                        type: 'line',
                        data: {
                            labels: data.lstYEARMONTH,//["2010-1", "2010-2", "2010-3", "2010-4"],
                            datasets: data.datasets,
                        },
                        options: {
                            responsive: true,
                            maintainAspectRatio: false
                        }
                    });
                });


            }
            if (this.reportType == "changeIndexReport") {
                this.displayedColumnsChangeIndex = ['countryCode', 'countryName', 'year', 'changeIndex'];

                this.dataSourceChangeIndex = new MatTableDataSource(data);
                this.dataSourceChangeIndex.sort = this.sort;
                this.dataSourceChangeIndex.paginator = this.paginator3;
                this.isFullReport = false;
                this.isYesIndexReport = false;
                this.isChangeIndexReport = true;

                this.dashboardService.getReportChart(filterCriteria).subscribe((data: any) => {
                    console.log(data);
                    var stackedLine = new Chart('canvasChangeIndexReport', {
                        type: 'line',
                        data: {
                            labels: data.lstYEARMONTH,//["2010-1", "2010-2", "2010-3", "2010-4"],
                            datasets: data.datasets,
                        },
                        options: {
                            responsive: true,
                            maintainAspectRatio: false
                        }
                    });
                });
               
            }
            this.reportData = data;
            console.log(data);
        });



    }

    // GetSelectedRow(row) {
    //     this.dashboardService.jobId = row.id;
    //     //this.NavigateToLog();

    //     this.router.navigate(['/log']);
    // }
    setValue(e) {
        if (e.checked) {
            this.bShowChart = true;
        } else {
            this.bShowChart = false;
        }
    }
    Print() {

    }

    GeneratePdf() {


    }


    colsFullReport = [{ title: "Country Code", key: "countryCode" }, { title: "Country Name", key: "countryName" }, { title: "Year", key: "year" }, { title: "Month", key: "monthName" }, { title: "Category", key: "categoryName" }, { title: "Indicator", key: "indicator" }];
    colsYesIndexReport = [{ title: "Country Code", key: "countryCode" }, { title: "Country Name", key: "countryName" }, { title: "Year", key: "year" }, { title: "Month", key: "monthName" }, { title: "Yes Index", key: "yesIndex" }];
    colsChangeIndexReport = [{ title: "Country Code", key: "countryCode" }, { title: "Country Name", key: "countryName" }, { title: "Year", key: "year" }, { title: "Change Index", key: "changeIndex" }];
    DownloadPDF() {
        var datePipe = new DatePipe('en-US');
        var currentdatetime = datePipe.transform(new Date().getTime(), 'dd-MMM-yy h:mm:ss');

        let doc = new jspdf();
        let cols: Array<Column> = new Array<Column>();
        let myList = this.reportData;
        console.log(this.reportData.length);
        if (this.reportData != undefined && this.reportData.length > 0) {

            /*let list = myList[0];
            for (let key in list) {
                let col: Column = new Column();
                col.title = key;
                col.key = key;
                cols.push(col);
            }
            */
            if (this.reportType == "fullReport") {
                cols = this.colsFullReport;
            }

            if (this.reportType == "yesIndexReport") {
                cols = this.colsYesIndexReport;
            }

            if (this.reportType == "changeIndexReport") {
                cols = this.colsChangeIndexReport;
            }
            doc.autoTable(cols, myList, {});
            doc.save(this.reportType + "_Year_" + this.selectedYears + "_" + currentdatetime + ".pdf");
        } else {
            this.toastr.error("Please select filter criteria to download the report", "", { "positionClass": "toast-top-center" });
        }


    }

    public GenerateExcel() {
        if (this.reportData != undefined && this.reportData.length > 0) {
            this.toexcel(this.reportData, this.reportType)
        }
        else {
            this.toastr.error("Please select filter criteria to download the report", "", { "positionClass": "toast-top-center" });
        }
    }

    public toexcel(json: any[], excelFileName: string): void {
        const worksheet: XLSX.WorkSheet = XLSX.utils.json_to_sheet(json);
        const workbook: XLSX.WorkBook = { Sheets: { 'List': worksheet }, SheetNames: ['List'] };
        const excelBuffer: any = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
        this.saveAsExcelFile(excelBuffer, excelFileName);
    }
    private saveAsExcelFile(buffer: any, fileName: string): void {
        var datePipe = new DatePipe('en-US');
        var currentdatetime = datePipe.transform(new Date().getTime(), 'dd-MMM-yy h:mm:ss');
        const data: Blob = new Blob([buffer], { type: EXCEL_TYPE });
        FileSaver.saveAs(data, fileName + "_Year_" + this.selectedYears + "_" + currentdatetime + EXCEL_EXTENSION);
    }

    onMultipleDeleteSelection(Type, Flag) {

    }

    DeleteLog(row) {

    }

}
