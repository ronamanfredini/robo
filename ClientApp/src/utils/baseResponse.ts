export class BaseResponse {
  constructor(
    public records: any,
    public success: boolean,
    public message: string) {
  }
}
