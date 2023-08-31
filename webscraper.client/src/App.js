import React, { useState } from 'react';
import './App.css';
import WebsiteCheckboxes from './components/website-checkboxes';
import ProductCheckboxes from './components/product-checkboxes';
import ScrapeButton from './components/scrape-button';
import axios from 'axios';

const App = () => {
  const [selectedWebsite, setSelectedWebsite] = useState([]);
  const [selectedProduct, setSelectedProduct] = useState([]);

  const handleProductSelection = (selectedProduct) => {
    setSelectedProduct(selectedProduct);
  };

  const handleWebsiteSelection = (selectedWebsite) => {
    setSelectedWebsite(selectedWebsite);
  };


  const handleScrape = () => {
    
      console.log('Selected Website:', selectedWebsite);
      console.log('Selected Product:', selectedProduct);

      axios.get()
      .then(res => {
        console.log(res)
      }).catch(err => {
        console.log(err)
      })
    
  };

  
  return (
    <div className="App">
      <h1>Web Scraper 1.0</h1>
      <div className='inputs'>
        

        <p>1. Which website would you like to scrape through?</p>
        <WebsiteCheckboxes setSelectedWebsite={handleWebsiteSelection}/>

        <p>2. Which product would you like to scrape for?</p>
        <ProductCheckboxes setSelectedProduct={handleProductSelection}/>
      </div>
      <br />
      <ScrapeButton onClick={handleScrape} />
      <hr className='dotted-line'/>
      <h1>Results</h1>

    </div>

  );
}

export default App;
