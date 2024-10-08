import PropertyDefinitionsContextProvider from './store/PropertyDefinitionsContext';
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import MainPage from './pages/Main/Main';

function App() {
  return (
    <PropertyDefinitionsContextProvider>
      <Header />
      <MainPage />
      <Footer />
    </PropertyDefinitionsContextProvider>
  );
}

export default App;
