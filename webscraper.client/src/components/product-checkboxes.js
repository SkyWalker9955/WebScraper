import React, { useState, useEffect, useRef  } from 'react';
import '../App.css';

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
    
      <div className='inputs2'>
        <div>
          <input
            type="checkbox"
            value='1'
            disabled={isCheckboxDisabled('1')}
            onChange={() => handleCheckboxChange('1')}
          />
          GPU
        </div>
        <div>
          <input
            type="checkbox"
            value='2'
            disabled={isCheckboxDisabled('2')}
            onChange={() => handleCheckboxChange('2')}
          />
          RAM
        </div>
        <div>
          <input
            type="checkbox"
            value='3'
            disabled={isCheckboxDisabled('3')}
            onChange={() => handleCheckboxChange('3')}
          />
          MCB
        </div>
        <div>
          <input
            type="checkbox"
            value='4'
            disabled={isCheckboxDisabled('4')}
            onChange={() => handleCheckboxChange('4')}
          />
          PWS
        </div>
        <div>
          <input
            type="checkbox"
            value='5'
            disabled={isCheckboxDisabled('5')}
            onChange={() => handleCheckboxChange('5')}
          />
          SSD
        </div>
      </div>

  );
}

export default ProductCheckboxes;
