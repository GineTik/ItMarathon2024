import { createContext, useEffect, useState } from 'react';

import { fetchPropertyDefinitions } from '../http';

export const PropertyDefinitionsContext = createContext({
  definitions: [],
});

export default function PropertyDefinitionsContextProvider({ children }) {
  const [propertyDefinitions, setPropertyDefinitions] = useState([]);

  useEffect(() => {
    (async () => {
      const propertyDefinitionsData = await fetchPropertyDefinitions();

      setPropertyDefinitions(propertyDefinitionsData);
    })();
  }, []);

  const propertyDefinitionsContextValue = {
    definitions: propertyDefinitions,
  };

  return (
    <PropertyDefinitionsContext.Provider value={propertyDefinitionsContextValue}>
      {children}
    </PropertyDefinitionsContext.Provider>
  );
}
