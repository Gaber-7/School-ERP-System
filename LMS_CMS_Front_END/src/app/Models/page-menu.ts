export class PageMenu {

  constructor(
    public id: number = 0,
    public en_name: string = '',
    public ar_name: string = '',
    public icon?: string,
    public route?: string,
    public order: number = 0,
    public page_ID?: number,
    public children: PageMenu[] = [],
    // UI Property
    public isExpanded: boolean = false
  ) { }

}