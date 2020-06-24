import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';

import { Observable } from 'rxjs';
import { AccountService } from '../Account/account.service';
//import { HttpRequest, HttpHandler, HttpInterceptor, HttpHeaderResponse, HttpSentEvent, HttpUserEvent, HttpResponse, HttpProgressEvent } from '@angular/common/http';

@Injectable()
export class AuthInterceptorService implements HttpInterceptor{

  constructor(private accountService: AccountService) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
  
    let currenteUser = this.accountService.getCurrentUser();

    if(currenteUser && currenteUser.token){

      request = request.clone(
        {
          setHeaders: {
            Authorization: 'Berarer ${currenteUser.token}'
          }
        }
      );

    }
    
    return next.handle(request);
  
    /*intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpSentEvent | HttpHeaderResponse | HttpProgressEvent | HttpResponse<any> | HttpUserEvent<any>> {
    
   //const token : string = localStorage.getItem('token');

    if(token){

      console.log("Token Chingon: " + token);
      console.log("Req Chingon: " +  req.clone({ headers: req.headers.set('Authorization', 'Bearer ' + token) }));

      return next.handle(req);
    
    }else{

      console.log("BadReq: " + req.responseType.toString);
      return next.handle(req);

    }
*/

  }

  
}
