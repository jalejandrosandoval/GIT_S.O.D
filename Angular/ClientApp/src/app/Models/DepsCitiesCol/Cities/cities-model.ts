import { IDeparmentsColModel } from '../Deparments/deparments-model';

export interface ICitiesModel {

    id_CitiesCol: number;
    cityName: string;
    id_DepartmentsCols: number;
    departmentsCol: IDeparmentsColModel[];
    
}