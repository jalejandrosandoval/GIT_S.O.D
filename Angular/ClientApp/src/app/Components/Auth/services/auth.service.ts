import { Injectable } from '@angular/core';


@Injectable()

export class AuthService {

  constructor() { }

  async login(username: string, password: string ) {

    //const res = await this.

  }

  logout() {}

  async recovery_password(username: string) {

    try{
      


    }
    catch(error){

      console.log(error);

    }

  }

  getCurrentUser() {}

}