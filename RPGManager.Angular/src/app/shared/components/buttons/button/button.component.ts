import { Component, input, OnInit } from '@angular/core';
import 'devtoolz-library';

type buttonType = "button" | "submit" | "reset";
type buttonStyle = "primary" | "secondary";

@Component({
  selector: 'rpg-button',
  standalone: true,
  imports: [],
  templateUrl: './button.component.html',
  styleUrl: './button.component.scss'
})
export class ButtonComponent implements OnInit {
  id = input<string>('button');
  label = input<string>();
  buttonType = input<string>('button');
  buttonStyle = input<string>('primary');

  protected getButtonClass(): string[] {
    let buttonClassList: string[] = ["btn"];

    if (this.buttonStyle().isNotEmpty())
      buttonClassList.push(`btn-${this.buttonStyle()}`);

    return buttonClassList;
  }

  ngOnInit(): void {

  }
}
