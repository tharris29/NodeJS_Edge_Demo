var edge = require('edge');
var http = require('http');
var port = process.env.port || 1337;

var callDotNet = edge.func(function () {/*

    #r "System.Data.dll"

    using System.Data;
    using System.Threading.Tasks;

    public class Startup
    {
        public async Task<object> Invoke(object input)
        {
            
            var x = new { cheese = "blue cheese" };

            return x;
        }
    }
*/
});



http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'application/json' });
    callDotNet('JavaScript', function (error, result) {
        if (error) throw error;
        res.end(JSON.stringify(result));
    });
}).listen(port);