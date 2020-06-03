import { Injectable } from "@angular/core";
import { RoboService } from "./robo.service";
import { Movimento } from "../utils/movimento";
import { BehaviorSubject, Observable } from "rxjs";
import { Robo } from "../models/robo";
import { map, tap } from "rxjs/operators";
import { BaseResponse } from "../utils/baseResponse";

@Injectable({ providedIn: 'root' })
export class StateChanger {
  private roboStore: BehaviorSubject<Robo>;

  constructor(private roboServices: RoboService) {
    this.roboStore = new BehaviorSubject<Robo>(null);
    roboServices.getRoboState().pipe(
      map((response: BaseResponse) => response.records),
      tap((robo: Robo) => this.roboStore.next(robo))
    ).subscribe();
  }

  public getListenner(): Observable<Robo> {
    return this.roboStore.asObservable();
  }

  public componentChanged(movimento: Movimento): void {
    this.roboServices.changeRoboPartState(movimento).pipe(
      map((response: BaseResponse) => response.records),
      tap((robo: Robo) => this.roboStore.next(robo))
    ).subscribe();
  }
}
