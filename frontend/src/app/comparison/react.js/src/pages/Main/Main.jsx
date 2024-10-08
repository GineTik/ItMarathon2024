import './Main.scss';

import { ERROR_MESSAGES, PET_CARDS_MOCK } from '../../app.config';
import { getProposalSex } from '../../util';
import { fetchNewestAds } from '../../http';
import useFetch from '../../hooks/useFetch';
import PetCategories from '../../components/PetCategories/PetCategories';
import PetCard from '../../components/PetCard/PetCard';
import SearchForm from '../../components/SearchForm/SearchForm';
import Loader from '../../components/Loader/Loader';
import Toaster from '../../components/Toaster/Toaster';

export default function MainPage() {
  const { isLoading, data: petCards, error: petCardsError, setError: setPetCardsError } = useFetch(fetchNewestAds, []);

  const handleCloseToaster = () => setPetCardsError(null);

  return (
    <div className="main-page-wrapper">
      <main className="main-page app-container">
        <header className="global-header">
          <h1 className="main-page__main-header">Звідси починається найкраща дружба</h1>
          <SearchForm />
        </header>

        <PetCategories className="main-page__pet-categories" />

        <section className="newest-ads-section">
          <h2 className="newest-ads-section__header">Найновіші оголошення</h2>

          {isLoading && <Loader />}

          {petCardsError && (
            <Toaster
              type="error"
              message={`${ERROR_MESSAGES.somethingWentWrong}: ${petCardsError.message}`}
              onClose={handleCloseToaster}
            />
          )}

          {!petCardsError && !isLoading && (
            <ul className="newest-ads-section__pet-cards">
              {/* for mock use PET_CARDS_MOCK */}
              {petCards.map(petCard => {
                const { title, location, age, price, summary } = petCard;
                const image = petCard.photos[0]?.image;
                const sex = getProposalSex(petCard);
                const petCardObject = { image, title, location, sex, age, price, summary };

                return (
                  <li key={petCard.id}>
                    <PetCard petCard={petCardObject} />
                  </li>
                );
              })}
            </ul>
          )}
        </section>
      </main>
    </div>
  );
}
