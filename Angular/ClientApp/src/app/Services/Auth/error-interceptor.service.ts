import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { AccountService } from '../Account/account.service';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class ErrorInterceptorService implements HttpInterceptor {

  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  // Interceptor of error in the petitions Http 

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    
    return next.handle(request).pipe(catchError(error => {

      if (error.status === 401) {

        return throwError(this.toastr.error(error.message || error.statusText, "Error de Conexión"));
      }

      if (error.status === 504) {
         
        return throwError(this.toastr.warning(error.message , "Error de Conexión con el servidor: "));
      }
      
      if (error.status === 400) {

        return throwError(error);

      }
   
    }));
  
  }

}
