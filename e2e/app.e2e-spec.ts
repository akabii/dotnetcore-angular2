import { AspngPage } from './app.po';

describe('aspng App', function() {
  let page: AspngPage;

  beforeEach(() => {
    page = new AspngPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
