import { DictionaryService } from '../../services/dictionary.service';
import { Router } from '@angular/router';
import { ROUTING_LIST } from '../../app.config';
import DICTIONARY_MOCK from '../../dictionary.mock';

const configLoader = (dictionaryService: DictionaryService, router: Router) => async () => await dictionaryService.loadMockDictionary();
// RETURN IT IF YOU HAVE USER API
//   await dictionaryService.loadDictionary();

export default configLoader;
