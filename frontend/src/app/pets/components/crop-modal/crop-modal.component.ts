import { Component, inject, signal, ViewChild, WritableSignal } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ImageCropperComponent } from 'ngx-image-cropper';

import { ModalWrapperComponent } from '../../../shared/components/modal-wrapper/modal-wrapper.component';
import { CrossButtonComponent } from '../../../shared/components/cross-button/cross-button.component';
import { ButtonComponent } from '../../../shared/components/button/button.component';
import { DndDirective } from '../../../shared/directives/dnd.directive';
import type { CropModalData } from '../../pets.model';

@Component({
  selector: 'pet-world-crop-modal',
  standalone: true,
  imports: [ModalWrapperComponent, ImageCropperComponent, CrossButtonComponent, ButtonComponent, DndDirective],
  templateUrl: './crop-modal.component.html',
  styleUrl: './crop-modal.component.scss',
})
export class CropModalComponent {
  @ViewChild('cropper') cropper!: ImageCropperComponent;

  imageChangedEvent: WritableSignal<Event | null> = signal(null);
  imageFile: WritableSignal<File | undefined> = signal(undefined);
  private dialogRef: MatDialogRef<CropModalComponent> = inject(MatDialogRef);
  private data: CropModalData = inject(MAT_DIALOG_DATA);

  fileChangeEvent(event: Event): void {
    this.imageChangedEvent.set(event);
  }

  onFileDropped(files: FileList) {
    this.imageFile.set(files[0]);
  }

  onConfirm(): void {
    const modalData = {
      controlIndex: this.data.controlIndex,
      croppedImage: this.cropper.crop('base64')?.base64,
    };

    this.dialogRef.close(modalData);
  }

  onClose(): void {
    this.dialogRef.close();
  }
}
