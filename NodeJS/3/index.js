const path = require("path");
const fs = require("fs");

const express = require("express");
const app = express();

const obj = {
  "/index": 0,
  "/about": 0,
};

const fileName = "log.json";
const filePath = path.join(__dirname, fileName);

app.get("/", (req, res) => {
  const fileContent = JSON.parse(fs.readFileSync(filePath));
  fileContent["/index"] = fileContent["/index"] + 1;
  res.send(`<h1> Hello, World!!!!</h1>
  <a href='/about'>ABOUT</a>
  Просмотров: ${fileContent["/index"]}`);

  fs.writeFileSync(filePath, JSON.stringify(fileContent));
});

app.get("/about", (req, res) => {
  const fileContent = JSON.parse(fs.readFileSync(filePath));
  fileContent["/about"] = fileContent["/about"] + 1;
  res.send(`<h1> Hello, About!!!!</h1>
  <a href='/'>MAIN</a>
  Просмотров: ${fileContent["/about"]}`);

  fs.writeFileSync(filePath, JSON.stringify(fileContent));
});

app.listen(3000);
