import { Component, OnInit } from '@angular/core';
import { BreadcrumbService } from 'params-xng-breadcrumb';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-section-header',
  templateUrl: './section-header.component.html',
  styleUrls: ['./section-header.component.scss']
})
export class SectionHeaderComponent implements OnInit {
  breadCrumb$: Observable<any[]>;

  constructor(private bcService: BreadcrumbService) { }

  ngOnInit(){
    this.breadCrumb$ = this.bcService.breadcrumbs$;
  }

}
