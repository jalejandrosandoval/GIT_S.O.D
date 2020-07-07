import { EmailValidator } from '@angular/forms';

export interface IUsers {
    
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
    
}