import axios from "axios";

export const Client = {
    defaultClient : axios.create({
        baseURL: "http://localhost:8090/api/cardgame/input"
    })
}