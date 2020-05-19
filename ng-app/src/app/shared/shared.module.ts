import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout';
import { RouterModule } from '@angular/router';
import { NavbarComponent } from './components';

@NgModule({
  declarations: [NavbarComponent],
  imports: [CommonModule, RouterModule, FlexLayoutModule],
  exports: [NavbarComponent],
})
export class SharedModule {}
