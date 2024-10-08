import { Component, computed, input, output } from '@angular/core';
import { CdkDragDrop, CdkDropList, CdkDrag, DragDropModule, moveItemInArray } from '@angular/cdk/drag-drop';
import { NgClass } from '@angular/common';

import { PhotoUploaderComponent } from '../../../shared/components/photo-uploader/photo-uploader.component';
import type { PhotoItem } from '../../../app.model';

@Component({
  selector: 'pet-world-gallery',
  standalone: true,
  imports: [PhotoUploaderComponent, NgClass, CdkDropList, CdkDrag, DragDropModule],
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss',
})
export class GalleryComponent {
  readonly photos = input<PhotoItem[]>([]);
  photoArray = computed(() => [...this.photos(), ...Array(4 - this.photos().length).fill({})].slice(0, 4));
  isEditMode = input<boolean>(false);
  photoPreviewId = 0;

  editPhoto = output<number>();
  removePhoto = output<number>();
  drag = output<CdkDragDrop<PhotoItem[]>>();

  get showPreviewImage(): boolean {
    return (
      !!this.photos().length && (!!this.photos()[this.photoPreviewId].url || !!this.photos()[this.photoPreviewId].image)
    );
  }

  drop(event: CdkDragDrop<PhotoItem[]>): void {
    this.drag.emit(event);
  }

  onClickPhoto(event: number): void {
    this.photoPreviewId = event;
  }

  onEditPhoto(event: number): void {
    this.editPhoto.emit(event);
  }

  onRemovePhoto(event: number): void {
    this.removePhoto.emit(event);
  }
}
