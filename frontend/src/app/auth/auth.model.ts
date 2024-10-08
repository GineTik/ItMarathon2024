import { FormControl } from '@angular/forms';

export interface LoginFormData {
  email: string;
  password: string;
}

export interface RegisterFormData extends LoginFormData {
  name: string;
  surname: string;
  location: string;
  confirmPassword: string;
}

export type NestedFormInterface<T extends LoginFormData> = {
  [key in keyof T]: FormControl<string>;
};

export type SignUpData = Omit<RegisterFormData, 'confirmPassword'>;

export interface LoginRequestData {
  username: string;
  password: string;
}

export interface LinkModalData {
  email: string;
}
