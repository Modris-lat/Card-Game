import { GetHandValuesApi } from "./components/GetHandValuesApi";
import { HandValuesRequest } from "./api/HandValuesRequest";

describe("getValues api", () => {
  it("should return correct values", async done => {
    const request1 = new HandValuesRequest("AsKc2d", ["8c3d", "7d4c", "TcJs"]);

    const response = await GetHandValuesApi.getValues(request1);
    expect(response.status).toBe(200);
    done();
  },100000)
})