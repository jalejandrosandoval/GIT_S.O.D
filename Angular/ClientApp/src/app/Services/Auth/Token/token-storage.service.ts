import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TokenStorageService {

  private token='';
  private token$ = new BehaviorSubject<string>('');

  constructor() { }

  public select$ = () => this.token$.asObservable();

  public dispathc(token){
    this.token = token;
    this.token$.next(this.token);
  }
}
