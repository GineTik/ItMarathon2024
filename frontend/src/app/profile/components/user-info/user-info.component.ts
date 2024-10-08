import { Component, computed, inject, input, OnInit } from '@angular/core';
import { NgClass } from '@angular/common';

import { ToasterService } from '../../../services/toaster.service';
import { TOASTER_MESSAGE, TOASTER_TYPE } from '../../../app.config';
import type { User } from '../../../app.model';

@Component({
  selector: 'pet-world-user-info',
  standalone: true,
  imports: [NgClass],
  templateUrl: './user-info.component.html',
  styleUrl: './user-info.component.scss',
})
export class UserInfoComponent implements OnInit {
  readonly user = input.required<User | null>();
  readonly isUserVerified = computed(() => this.user()?.is_verified || false);
  readonly isUserComplete = computed(() => this.user()?.is_verified && this.user()?.phone_number && this.user()?.email);

  private readonly toasterService = inject(ToasterService);

  ngOnInit() {
    if (!this.isUserComplete()) {
      this.toasterService.show(TOASTER_TYPE.WARNING, TOASTER_MESSAGE.UNCOMPLETED_USER);
    }
  }
}
