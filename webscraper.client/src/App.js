import React, { useState } from 'react';
import './App.css';
import WebsiteCheckboxes from './components/website-checkboxes';
import ProductCheckboxes from './components/product-checkboxes';
import ScrapeButton from './components/scrape-button';
import axios from 'axios';

const App = () => {

  const [selectedWebsite, setSelectedWebsite] = useState([]);
  const [selectedProduct, setSelectedProduct] = useState([]);
  const [products, setProducts] = useState([]); // State to store the fetched products

  const handleProductSelection = (selectedProduct) => {
    setSelectedProduct(selectedProduct);
  };

  const handleWebsiteSelection = (selectedWebsite) => {
    setSelectedWebsite(selectedWebsite);
  };


  /*const config = {
    headers: { '': 'Bearer ' + token }
  };*/

  const fetchDummyProducts = () => {
    // Simulate an API call to fetch dummy product data
    axios
      .get('http://localhost:23677/scrape') //, config     -    You can replace this URL with your own API endpoint or use a JSON file
      .then((res) => {
        // Assuming res.data is an array of dummy products
        setProducts(res.data);
      })
      .catch((err) => {
        console.error(err);
      });
  };

  const handleScrape = () => {
    console.log('Selected Website:', selectedWebsite);
    console.log('Selected Product:', selectedProduct);

    // Call the function to fetch dummy products
    fetchDummyProducts();
  };

  return (
    <div className="App">
      <h1>Web Scraper 1.0</h1>
      <div className='inputs'>
        <p>1. Which website would you like to scrape through?</p>
        <WebsiteCheckboxes setSelectedWebsite={handleWebsiteSelection} />

        <p>2. Which product would you like to scrape for?</p>
        <ProductCheckboxes setSelectedProduct={handleProductSelection} />
      </div>
      <br />
      <ScrapeButton onClick={handleScrape} />
      <hr className='dotted-line' />


      <h1>Results</h1>
      <ul>
        {products.map((product) => (
          <li key={product.id}>
            <strong>Name:</strong> {product.name}, <strong>Cost:</strong> {product.price}, <strong>Description:</strong>{' '}
            {product.description}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
