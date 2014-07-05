var edge = require('edge');
var http = require('http');
var port = process.env.port || 1337;

var GetCheese = edge.func({
    assemblyFile: 'dotNetService.dll',
    typeName: 'dotNetService.Service',
    methodName: 'GetCheese' // This must be Func<object,Task<object>>
});

http.createServer(function (req, res) {
    if (req.url == "/cheese") {
        res.writeHead(200, { 'Content-Type': 'application/json' });
        GetCheese('JavaScript', function(error, result) {
            if (error) throw error;
            res.end(JSON.stringify(result));
        });
    }
}).listen(port);