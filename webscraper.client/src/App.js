import React, { useState } from 'react';
import './App.css';
import WebsiteCheckboxes from './components/website-checkboxes';
import ProductCheckboxes from './components/product-checkboxes';
import ScrapeButton from './components/scrape-button';
import axios from 'axios';
import Spinner from 'react-bootstrap/Spinner';
import 'bootstrap/dist/css/bootstrap.min.css';

const App = () => {

  const [selectedWebsite, setSelectedWebsite] = useState([]);
  const [selectedProduct, setSelectedProduct] = useState([]);
  const [products, setProducts] = useState([]); 
  const [showSpinner, setShowSpinner] = useState(false);

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
    axios
      .get('http://localhost:23677/scrape') //, config     -    You can replace this URL with your own API endpoint or use a JSON file
      .then((res) => {
        setProducts(res.data);
      })
      .catch((err) => {
        console.error(err);
      });
  };

  const handleScrape = () => {
    console.log('Selected Website:', selectedWebsite);
    console.log('Selected Product:', selectedProduct);

    setShowSpinner(true);

    fetchDummyProducts();

    setTimeout(() => {
      setShowSpinner(false);
    }, 5000);
  };

  return (
    <div className="App">
      <h1 class="display-2">Web Scraper 1.0</h1>
      <div className='inputs'>
        <p><b>1.</b> Which website would you like to scrape through?</p>
        <WebsiteCheckboxes setSelectedWebsite={handleWebsiteSelection} />

        <p><b>2.</b> Which product would you like to scrape for?</p>
        <ProductCheckboxes setSelectedProduct={handleProductSelection} />
      </div>
      <br />
      <ScrapeButton onClick={handleScrape} />
      <hr className='dotted-line' />


      <h1 class="display-6">Results</h1>
      {showSpinner ? (
        <Spinner animation="border" variant="primary" />
      ) : (
        <ul>
          {products.map((product) => (
            <li key={product.id}>
              <strong>Name:</strong> {product.name}, <strong>Cost:</strong> {product.price}, <strong>Description:</strong>{' '}
              {product.description}
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export default App;
