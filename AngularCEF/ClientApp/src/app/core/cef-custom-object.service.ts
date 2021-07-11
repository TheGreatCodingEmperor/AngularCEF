import { Injectable } from '@angular/core';
import { promise } from 'protractor';

@Injectable({
  providedIn: 'root'
})
export class CefCustomObjectService {
  cefCustomObject = window['cefCustomObject'];
  ShowDevTools(){
    this.cefCustomObject.showDevTools();
  }
  RefreshWindow(){
    this.cefCustomObject.refreshWindow();
  }

  async SayHello(){
    console.log(await this.cefCustomObject.sayHello())
    return await this.cefCustomObject.sayHello();
  }
}
