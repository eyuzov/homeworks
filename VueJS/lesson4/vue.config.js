const { defineConfig } = require("@vue/cli-service");
module.exports = defineConfig({
  publicPath: process.env.NODE_ENV === "production" ? "/lesson4/" : "/",
  pages: {
    index: {
      entry: "src/main.js",
      template: "public/index.html",
      filename: "index.html",
      title: process.env.VUE_APP_NAME || "Application",
    },
    blog: {
      entry: "src/blog/main.js",
      template: "public/blog.html",
      filename: "blog.html",
      title: process.env.VUE_APP_NAME || "Application",
    },
    blog_details: {
      entry: "src/blog_details/main.js",
      template: "public/blog_details.html",
      filename: "blog_details.html",
      title: process.env.VUE_APP_NAME || "Application",
    },
  },
  transpileDependencies: true,
});
