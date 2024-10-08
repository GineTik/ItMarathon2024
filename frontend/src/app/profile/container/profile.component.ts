import { Component, inject, OnInit, Signal, ViewChild } from '@angular/core';
import { AsyncPipe } from '@angular/common';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { map, Observable } from 'rxjs';

import { BUTTON_CONTENT, ROUTING_LIST } from '../../app.config';
import { UserInfoComponent } from '../components/user-info/user-info.component';
import { ButtonComponent } from '../../shared/components/button/button.component';
import { PetCardComponent } from '../../shared/components/pet-card/pet-card.component';
import { CrossButtonComponent } from '../../shared/components/cross-button/cross-button.component';
import { NotificationComponent } from '../components/notification/notification.component';
import { CreatedPetCardModalComponent } from '../../pets/components/created-pet-card-modal/created-pet-card-modal.component';
import { UserService } from '../../services/user.service';
import type { ProposalItem, User } from '../../app.model';

@Component({
  selector: 'pet-world-profile',
  standalone: true,
  imports: [
    UserInfoComponent,
    ButtonComponent,
    PetCardComponent,
    CrossButtonComponent,
    NotificationComponent,
    AsyncPipe,
  ],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.scss',
})
export class ProfileComponent implements OnInit {
  @ViewChild('notification') notification!: NotificationComponent;

  readonly buttonContent = BUTTON_CONTENT;

  private readonly route = inject(ActivatedRoute);
  private readonly dialog = inject(MatDialog);
  private readonly router = inject(Router);
  private readonly userService = inject(UserService);

  proposals$!: Observable<ProposalItem[]>;
  user!: Signal<User | null>;

  ngOnInit() {
    this.getPageDate();
    this.onNewProposal();
    this.user = this.userService.user;
  }

  toggleClass(): void {
    this.notification.toggleVisibility();
  }

  onProposal(id: number): void {
  }

  private getPageDate(): void {
    this.proposals$ = this.route.data.pipe(map(data => data['proposals'].items));
  }

  private onNewProposal(): void {
    const historyState = window.history.state;
    const isNewProposal = historyState?.['isProposalAdded'] || false;

    if (!isNewProposal) return;

    this.dialog.open(CreatedPetCardModalComponent, {
      minWidth: '600px',
    });
  }
}
