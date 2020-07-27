import { EmailValidator } from '@angular/forms';
import { IUsersTypesModel } from '../UsersTypes/users-types-model';

export interface IUsersModel {

    id_Users: number;
    n_Identification: number;
    typeDocument: string;
    firstName: string;
    lastName: string;
    username: string;
    userPassword: string;
    status: boolean;
    id_UsersType: number;
    userType: IUsersTypesModel[];

}