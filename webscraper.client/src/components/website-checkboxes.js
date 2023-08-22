import React, { useState, useEffect, useRef } from 'react';
import '../App.css';

const WebsiteCheckboxes = ({setSelectedWebsite}) => {
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
    
      
      <div className='inputs1'>
        <div>
          <input
            type="checkbox"
            value='1'
            disabled={isCheckboxDisabled('1')}
            onChange={() => handleCheckboxChange('1')}
          />
          Amazon
        </div>
        <div>
          <input
            type="checkbox"
            value='2'
            disabled={isCheckboxDisabled('2')}
            onChange={() => handleCheckboxChange('2')}
          />
          Best Buy
        </div>
        <div>
          <input
            type="checkbox"
            value='3'
            disabled={isCheckboxDisabled('3')}
            onChange={() => handleCheckboxChange('3')}
          />
          Newegg
        </div>
        <div>
          <input
            type="checkbox"
            value='4'
            disabled={isCheckboxDisabled('4')}
            onChange={() => handleCheckboxChange('4')}
          />
          Micro Center
        </div>
      </div>

  );
}

export default WebsiteCheckboxes;
