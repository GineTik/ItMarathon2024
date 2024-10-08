import { inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { ENDPOINT } from '../app.config';
import { TokenService } from './token.service';
import type { ParentDictionaryItem, PetRequestBody, ProposalItem, ProposalResponse, Token, User } from '../app.model';
import type { LoginRequestData, SignUpData } from '../auth/auth.model';

const DOT_NET_API_URL = 'https://dotnet-v4itmarathon-prod.azurewebsites.net/api/';
const PYTHON_API_URL = 'https://python-v4-itmarathon-prod.azurewebsites.net/api/';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private readonly httpClient = inject(HttpClient);
  private readonly tokenService = inject(TokenService);

  getDictionary(): Observable<ParentDictionaryItem[]> {
    return this.httpClient.get<ParentDictionaryItem[]>(`${DOT_NET_API_URL}${ENDPOINT.DICTIONARY}`);
  }

  getProposalList(query: string): Observable<ProposalResponse> {
    return this.httpClient.get<ProposalResponse>(`${DOT_NET_API_URL}${ENDPOINT.PROPOSALS}${query}`);
  }

  getProposal(proposalId: number): Observable<ProposalItem> {
    return this.httpClient.get<ProposalItem>(`${DOT_NET_API_URL}${ENDPOINT.PROPOSALS}/${proposalId}`);
  }

  addProposal(proposalData: PetRequestBody): Observable<any> {
    const headers = { Authorization: `Bearer ${this.tokenService.getToken()}` };

    return this.httpClient.post<any>(`${DOT_NET_API_URL}${ENDPOINT.PROPOSALS}`, proposalData, { headers });
  }

  updateProposal(proposalId: number, proposalData: Partial<any>): Observable<any> {
    const headers = { Authorization: `Bearer ${this.tokenService.getToken()}` };

    return this.httpClient.put(`${DOT_NET_API_URL}${ENDPOINT.PROPOSALS}?id=${proposalId}`, proposalData, { headers });
  }

  deleteProposal(proposalId: number): Observable<any> {
    return this.httpClient.delete(`${DOT_NET_API_URL}${ENDPOINT.PROPOSALS}?id=${proposalId}`);
  }

  signUp(formValue: SignUpData): Observable<User> {
    return this.httpClient.post<User>(`${PYTHON_API_URL}${ENDPOINT.SIGN_UP}`, formValue);
  }

  signIn(formValue: LoginRequestData): Observable<Token> {
    const urlEncodedData = new URLSearchParams(Object.entries(formValue)).toString();
    const headers = new HttpHeaders({
      'Content-Type': 'application/x-www-form-urlencoded',
    });

    return this.httpClient.post<Token>(`${PYTHON_API_URL}${ENDPOINT.SIGN_IN}`, urlEncodedData, { headers });
  }

  getUserByToken(token: string): Observable<User> {
    const headers = { Authorization: `Bearer ${token}` };

    return this.httpClient.get<User>(`${PYTHON_API_URL}${ENDPOINT.ME}`, { headers });
  }

  forgotPassword(email: string): Observable<string> {
    return this.httpClient.post<string>(`${PYTHON_API_URL}${ENDPOINT.FORGOT_PASSWORD}`, { email });
  }

  createNewPassword(password: string): Observable<string> {
    const body = { password, token: `Bearer ${this.tokenService.getToken()}` };

    return this.httpClient.post<string>(`${PYTHON_API_URL}${ENDPOINT.RESET_PASSWORD}`, { body });
  }
}
