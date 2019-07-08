import { ReuseTabTemplatePage } from './app.po';

describe('ReuseTab App', function() {
  let page: ReuseTabTemplatePage;

  beforeEach(() => {
    page = new ReuseTabTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
