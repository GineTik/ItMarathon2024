import { useEffect, useState } from 'react';

export default function useFetch(fetchFn, initialData) {
  const [isLoading, setIsLoading] = useState(false);
  const [data, setData] = useState(initialData);
  const [error, setError] = useState();

  useEffect(() => {
    setIsLoading(true);

    (async () => {
      try {
        const data = await fetchFn();

        setData(data);
      } catch (error) {
        setError(error);
      }

      setIsLoading(false);
    })();
  }, []);

  return {
    isLoading,
    data,
    error,
    setError,
  };
}
