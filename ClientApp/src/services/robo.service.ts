import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { map, tap } from "rxjs/operators";
import { BaseResponse } from "../utils/baseResponse";
import { Movimento } from "../utils/movimento";

@Injectable({ providedIn: "root" })
export class RoboService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) {
    this._baseUrl = _baseUrl + "api/";
  }

  public getRoboState(): Observable<BaseResponse> {
    return this.http.get(this._baseUrl + "robo").pipe(
      map((response: any) => new BaseResponse(response.records, response.success, response.message))
    );
  }

  public changeRoboPartState(movimento: Movimento): Observable<BaseResponse> {
    return this.http.patch(this._baseUrl + "robo", movimento).pipe(
      map((response: any) => new BaseResponse(response.records, response.success, response.message)),
      tap(response => { if (!response.success) alert(response.message) })
    );
  }
}
