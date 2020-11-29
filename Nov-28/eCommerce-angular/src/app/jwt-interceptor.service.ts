import {
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class JwtInterceptorService implements HttpInterceptor {
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    console.log('JwtInterceptorService');

    if (localStorage.token) {
      //create request header
      req = req.clone({
        setHeaders: {
          Authorization: `Bearer ${localStorage.token}`,
        },
      });
    }
    return next.handle(req);
  }
}
