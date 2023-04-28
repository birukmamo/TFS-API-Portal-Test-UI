< !DOCTYPE html >
 < html >
 < head >
 
	 < title > TFS API Portal</title>
		<style>

			body {

				background-image: url('/Users/Sister/Downloads/TFS API Portal Image.png');
background - repeat: no - repeat;
background - size: cover;
		}
	</ style >
	< script src = "https://d1kzd4gjnuib76.cloudfront.net/lex-web-ui-loader.js" ></ script >
 
	 < script >
		 var loaderOptions = {
configUrl: 'https://d1kzd4gjnuib76.cloudfront.net/lex-web-ui-loader-config.json',
			baseUrl: 'https://dwz8vdco01vbe.cloudfront.net'
 		};

var iframeLoader = new ChatBotUiLoader.IframeLoader(loaderOptions);
console.log(iframeLoader.config)
		iframeLoader.load()
			.then(function() {
	console.log('iframe loaded');
})
			.catch (function (err) {
	console.error(err);
});
	</ script >
</ head >
< body ></ body >
</ html >
