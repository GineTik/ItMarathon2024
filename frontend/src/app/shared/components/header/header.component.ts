import { Component, inject, OnInit, Signal } from '@angular/core';
import { RouterLink } from '@angular/router';

import { ButtonComponent } from '../button/button.component';
import { BUTTON_CONTENT, ROUTING_LIST, STORAGE_KEYS } from '../../../app.config';
import { UserService } from '../../../services/user.service';
import type { User } from '../../../app.model';

@Component({
  selector: 'pet-world-header',
  standalone: true,
  imports: [ButtonComponent, RouterLink],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss',
})
export class HeaderComponent implements OnInit {
  private readonly userService = inject(UserService);

  readonly routingList = ROUTING_LIST;
  readonly buttonContent = BUTTON_CONTENT;

  user: Signal<User | null> = this.userService.user;

  ngOnInit() {
    this.getUser();
  }

  private getUser(): void {
    const user = localStorage.getItem(STORAGE_KEYS.USER);

    if (!user) return;

    this.userService.setUser(JSON.parse(user));
  }
}
