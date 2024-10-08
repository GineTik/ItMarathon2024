import { Component, OnInit, Signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

import { HeaderComponent } from './shared/components/header/header.component';
import { FooterComponent } from './shared/components/footer/footer.component';
import { LoaderComponent } from './shared/components/loader/loader.component';
import { ToasterComponent } from './shared/components/toaster/toaster.component';
import { TOASTER_MESSAGE, TOASTER_TYPE } from './app.config';
import { ToasterService } from './services/toaster.service';

@Component({
  selector: 'pet-world-root',
  standalone: true,
  imports: [HeaderComponent, RouterOutlet, FooterComponent, LoaderComponent, ToasterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent implements OnInit {
  title = 'it-marathon-v4';
  showToaster!: Signal<boolean>;
  toasterType!: Signal<TOASTER_TYPE>;
  toasterMessage!: Signal<TOASTER_MESSAGE>;

  constructor(private toasterService: ToasterService) {}

  ngOnInit() {
    this.showToaster = this.toasterService.isToasterShowed;
    this.toasterType = this.toasterService.toasterType;
    this.toasterMessage = this.toasterService.toasterMessage;
  }
}
