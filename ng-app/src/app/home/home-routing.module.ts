import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent, LatestComponent } from './pages';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'latest', component: LatestComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule {}
