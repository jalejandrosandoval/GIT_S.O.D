import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpSentEvent, HttpHeaderResponse, HttpProgressEvent, HttpResponse, HttpUserEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AccountService } from '../Account/account.service';

@Injectable({
  providedIn: 'root'
})
export class AuthInterceptorService {

  constructor(private accountService: AccountService) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpSentEvent | HttpHeaderResponse | HttpProgressEvent | HttpResponse<any> | HttpUserEvent<any>> {
    var token = this.accountService.getToken();
    request = request.clone({
      setHeaders: { Authorization: "bearer " + token }
    });
    return next.handle(request);
  }

}
