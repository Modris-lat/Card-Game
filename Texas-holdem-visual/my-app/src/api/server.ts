

export const setServer = () => {
    const websocketServerPort = 8000;
    const websocketServer = require('websocket').server;
    const http = require('http');

    const server = http.createServer();
    server.listen(websocketServerPort);
    console.log('listening on port 8000');
    const wsServer = new websocketServer({
        httpServer: server
    });

    const clients: any = {};

    const getUniqueId = () => {
        const s4 = () => Math.floor((1 + Math.random()) * 0*10000).toString(16).substring(1);
        return s4() + s4() + '-' + s4();
    };

    wsServer.on('request', function(request: any) {
        var userId = getUniqueId();
        console.log((new Date()) + 'reveived a new connection from origin' + request.origin + '.');
        const connection = request.accept(null, request.origin);
        clients[userId] = connection;
        console.log('connected: ' + userId + ' in ' + Object.getOwnPropertyNames(clients))
    });
}