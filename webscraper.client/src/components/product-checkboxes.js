import React, { useState, useEffect, useRef } from 'react';
import '../App.css';
import Form from 'react-bootstrap/Form';

const ProductCheckboxes = ({ setSelectedProduct }) => {
  const [checkedValues, setCheckedValues] = useState([]);
  const prevCheckedValuesRef = useRef([]);

  useEffect(() => {
    if (prevCheckedValuesRef.current !== checkedValues) {
      setSelectedProduct(checkedValues);
      console.log(checkedValues);
    }
    // Store the current checkedValues for the next comparison
    prevCheckedValuesRef.current = checkedValues;
  }, [checkedValues, setSelectedProduct]);

  const handleCheckboxChange = (value) => {
    if (checkedValues.includes(value)) {
      setCheckedValues(checkedValues.filter(val => val !== value));
    } else {
      setCheckedValues([...checkedValues, value]);
    }
  };

  const isCheckboxDisabled = (value) => {
    return checkedValues.length > 0 && !checkedValues.includes(value);
  };



  return (

    <Form>
      <Form.Check
        type="checkbox"
        id="checkbox1"
        label="GPU"
        value="1"
        disabled={isCheckboxDisabled('1')}
        checked={checkedValues.includes('1')}
        onChange={() => handleCheckboxChange('1')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox2"
        label="RAM"
        value="2"
        disabled={isCheckboxDisabled('2')}
        checked={checkedValues.includes('2')}
        onChange={() => handleCheckboxChange('2')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox3"
        label="MCB"
        value="3"
        disabled={isCheckboxDisabled('3')}
        checked={checkedValues.includes('3')}
        onChange={() => handleCheckboxChange('3')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox4"
        label="PWS"
        value="4"
        disabled={isCheckboxDisabled('4')}
        checked={checkedValues.includes('4')}
        onChange={() => handleCheckboxChange('4')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox5"
        label="SSD"
        value="5"
        disabled={isCheckboxDisabled('5')}
        checked={checkedValues.includes('5')}
        onChange={() => handleCheckboxChange('5')}
      />
    </Form>

  );
}

export default ProductCheckboxes;
