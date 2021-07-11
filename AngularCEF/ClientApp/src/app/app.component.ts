import { Component, OnInit } from '@angular/core';
import { CefCustomObjectService } from './core/cef-custom-object.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'front-end';
  constructor(private cefCustomObject: CefCustomObjectService) {}
  ngOnInit() {
    document.querySelector('body').addEventListener('keydown', (e) => {
      var keyCode = e.keyCode || e.which;
      var keys = e.key;
      switch (keyCode) {
        //F5 refresh
        case 116: {
          this.cefCustomObject.RefreshWindow();
          break;
        }
        //F12 dev tool
        case 123: {
          this.cefCustomObject.ShowDevTools();
          break;
        }
        case 13:{
          this.cefCustomObject.SayHello();
          break;
        }
        default:{
          break;
        }
      }
    });
  }
}
