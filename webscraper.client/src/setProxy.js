// In your React app's setup, install http-proxy-middleware:
// npm install http-proxy-middleware

const { createProxyMiddleware } = require('http-proxy-middleware');

module.exports = function (app) {
  app.use(
    '/api', // Specify the path that triggers the proxy
    createProxyMiddleware({
      target: 'http://localhost:23677', // Replace with the actual API server URL
      changeOrigin: true, // Change the origin of the request to match the target server
      // Add any other configuration options you need
    })
  );
};
