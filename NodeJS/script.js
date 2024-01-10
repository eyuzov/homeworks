const http = require("http");
let counter1 = 0;
let counter2 = 0;
const server = http.createServer((req, res) => {
  if (req.url === "/") {
    counter1++;
    res.writeHead(200, { "Content-Type": "text/html; charset=UTF-8" });
    res.end(`<a href="/about">about</a> 
    Посещений = ${counter1}`);
  } else if (req.url === "/about") {
    counter2++;
    res.writeHead(200, { "Content-Type": "text/html; charset=UTF-8" });
    res.end(`<a href="/">main</a> 
    Посещений =  ${counter2}`);
  } else {
    res.writeHead(404, { "Content-Type": "text/html; charset=UTF-8" });
    res.end("<h1> 404 </h1>");
  }
});

const port = 3000;

server.listen(port);
