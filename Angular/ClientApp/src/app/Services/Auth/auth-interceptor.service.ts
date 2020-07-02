import { Injectable } from '@angular/core';
//import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';

import { Observable } from 'rxjs';
import { AccountService } from '../Account/account.service';
import { HttpRequest, HttpHandler, HttpInterceptor, HttpHeaderResponse, HttpSentEvent, HttpUserEvent, HttpResponse, HttpProgressEvent } from '@angular/common/http';

@Injectable()
export class AuthInterceptorService implements HttpInterceptor{

  constructor(private accountService: AccountService) { }

  /*
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
  
    let currenteUser = this.accountService.getCurrentUser();

    if(currenteUser){

      request = request.clone(
        {
          setHeaders: {
            Authorization: 'Berarer' + currenteUser.
          }
        }
      );

    }*/
    
    //return next.handle(request);
  
    // Interceptor of petitions Http and Add the JWT in the Headers of Petions for validations issues

  intercept(req: HttpRequest<any>, next: HttpHandler): 
            Observable<HttpSentEvent | 
            HttpHeaderResponse | 
            HttpProgressEvent | 
            HttpResponse<any> | 
            HttpUserEvent<any>> {
    
   const token : string = localStorage.getItem('token');

    if(token){

      return next.handle(req);
    
    }else{

      return next.handle(req);

    }

  }
  
}
