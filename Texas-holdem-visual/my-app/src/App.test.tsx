import { Client } from "./Client";
import {HandValuesRequest} from "./api/handValuesRequest";

describe("getValues api", () => {
  const request = new HandValuesRequest("AsKc2d", ["8c3d", "7d4c", "TcJs"]);
  it("should return status OK", async () => {
    const response = await Client.defaultClient.post("", request);

    expect(response.status).toBe(200);
  });
});