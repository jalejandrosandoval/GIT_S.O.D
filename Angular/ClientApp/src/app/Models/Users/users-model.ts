import { EmailValidator } from '@angular/forms';

export interface IUsersModel {

    idUsers: number;
    N_Identification: number;
    TypeDocument: string;
    FirstName: string;
    LastName: string;
    UserEmail: EmailValidator;
    Username: string;
    UserPassword: string;
    Status: string;
    UserType: number;
    token?: string;
}
