import React, { useState, useEffect, useRef } from 'react';
import '../App.css';
import Form from 'react-bootstrap/Form';


const WebsiteCheckboxes = ({ setSelectedWebsite }) => {
  const [checkedValues, setCheckedValues] = useState([]);
  const prevCheckedValuesRef = useRef([]);

  useEffect(() => {
    if (prevCheckedValuesRef.current !== checkedValues) {
      setSelectedWebsite(checkedValues);
      console.log(checkedValues);
    }
    // Store the current checkedValues for the next comparison
    prevCheckedValuesRef.current = checkedValues;
  }, [checkedValues, setSelectedWebsite]);

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
        label="Amazon"
        value="1"
        disabled={isCheckboxDisabled('1')}
        checked={checkedValues.includes('1')}
        onChange={() => handleCheckboxChange('1')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox2"
        label="Best Buy"
        value="2"
        disabled={isCheckboxDisabled('2')}
        checked={checkedValues.includes('2')}
        onChange={() => handleCheckboxChange('2')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox3"
        label="Newegg"
        value="3"
        disabled={isCheckboxDisabled('3')}
        checked={checkedValues.includes('3')}
        onChange={() => handleCheckboxChange('3')}
      />
      <Form.Check
        type="checkbox"
        id="checkbox4"
        label="Micro Center"
        value="4"
        disabled={isCheckboxDisabled('4')}
        checked={checkedValues.includes('4')}
        onChange={() => handleCheckboxChange('4')}
      />
    </Form>

  );
}

export default WebsiteCheckboxes;
