import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
    constructor() {
 	
    }
    isSidebar = false
    ngOnInit(): void {        
        
    }       
showSidebar(){
        this.isSidebar = !this.isSidebar
    }
}