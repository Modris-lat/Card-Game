import axios from "axios";

export const Clients = {
    defaultClient : axios.create({
        baseURL: "http://localhost:8090/api/cardgame/input"
    })
}