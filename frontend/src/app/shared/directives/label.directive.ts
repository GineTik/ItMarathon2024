import { computed, Directive, effect, ElementRef, input, OnInit, Renderer2, Signal } from '@angular/core';

@Directive({
  selector: '[petWorldLabel]',
  standalone: true,
})
export class LabelDirective implements OnInit {
  readonly labelContent = input<string>('', { alias: 'petWorldLabel' });
  readonly isRequired = input.required<boolean>();
  readonly isInvalid = input<boolean>();
  readonly isNeedWrapper: Signal<boolean> = computed(() => !!this.labelContent() || this.isRequired());

  private readonly labelGeneralColor = '#49454f';
  private readonly asteriskGeneralColor = '#b3261e';
  private readonly alertColor = '#ff0000';

  private asterisk!: Element;
  private label!: Element;

  constructor(
    private el: ElementRef,
    private renderer: Renderer2,
  ) {
    effect(() => {
      if (this.isInvalid()) {
        if (this.label) this.renderer.setStyle(this.label, 'color', this.alertColor);
        if (this.asterisk) this.renderer.setStyle(this.asterisk, 'color', this.alertColor);
      } else {
        if (this.label) this.renderer.setStyle(this.label, 'color', this.labelGeneralColor);
        if (this.asterisk) this.renderer.setStyle(this.asterisk, 'color', this.asteriskGeneralColor);
      }
    });
  }

  ngOnInit() {
    this.addWrapper();
  }

  private createLabel() {
    const content = this.renderer.createText(this.labelContent());
    this.setLabelStyles();
    this.renderer.appendChild(this.label, content);
  }

  private setLabelStyles(): void {
    this.renderer.setStyle(this.label, 'position', 'absolute');
    this.renderer.setStyle(this.label, 'top', 0);
    this.renderer.setStyle(this.label, 'left', '12px');
    this.renderer.setStyle(this.label, 'z-index', 1049);
    this.renderer.setStyle(this.label, 'padding', '0 4px');
    this.renderer.setStyle(this.label, 'font-size', '12px');
    this.renderer.setStyle(this.label, 'line-height', '16px');
    this.renderer.setStyle(this.label, 'letter-spacing', '0.4px');
    this.renderer.setStyle(this.label, 'background-color', '#fff');
    this.renderer.setStyle(this.label, 'transform', 'translateY(-50%)');
    this.renderer.setStyle(this.label, 'user-select', 'none');
  }

  private addAsterisk(): void {
    this.asterisk = this.renderer.createElement('span');
    const text = this.renderer.createText('*');
    this.renderer.appendChild(this.asterisk, text);
    this.renderer.addClass(this.asterisk, 'asterisk');
    this.renderer.appendChild(this.label, this.asterisk);
  }

  private addWrapper(): void {
    if (this.isNeedWrapper()) {
      this.renderer.setStyle(this.el.nativeElement, 'position', 'relative');
      this.label = this.renderer.createElement('span');
    }

    if (this.labelContent()) {
      this.createLabel();
    }

    if (this.isRequired() && this.labelContent()) {
      this.addAsterisk();
    }

    if (this.isNeedWrapper()) {
      this.renderer.appendChild(this.el.nativeElement, this.label);
    }
  }
}
