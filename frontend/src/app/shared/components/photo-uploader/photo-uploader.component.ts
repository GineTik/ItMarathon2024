import { Component, input, output } from '@angular/core';
import { ImageCropperComponent } from 'ngx-image-cropper';
import { EditButtonComponent } from '../edit-button/edit-button.component';

@Component({
  selector: 'pet-world-photo-uploader',
  standalone: true,
  imports: [ImageCropperComponent, EditButtonComponent],
  templateUrl: './photo-uploader.component.html',
  styleUrl: './photo-uploader.component.scss',
})
export class PhotoUploaderComponent {
  controlIndex = input.required<number>();
  image = input.required<string>();
  showEditButton = input<boolean>(false);
  previewMode = input<boolean>(false);

  clickPhoto = output<number>();
  editPhoto = output<number>();
  removePhoto = output<number>();

  onClickPhoto(): void {
    this.clickPhoto.emit(this.controlIndex());
  }

  onClickEditButton(): void {
    this.editPhoto.emit(this.controlIndex());
  }

  onClickRemoveButton(event: Event): void {
    event.stopPropagation();
    this.removePhoto.emit(this.controlIndex());
  }
}
