import React from 'react';
import Button from 'react-bootstrap/Button';

const ScrapeButton = ({onClick}) => {
  return (
    <Button variant="primary" size="lg" onClick={onClick}>
      Scrape 
    </Button>
  );
}

export default ScrapeButton;