
var data = [
            { 
                ContactId: 1, 
                Address: { AddressId: 1, StreetAddress: "123 AnyStreet", City: "AnyTown", State: "UT" }, 
                FirstName: "Bob", 
                LastName: "Builder"
            },
            { 
                ContactId: 2, 
                Address: { AddressId: 2, StreetAddress: "456 AnyStreet", City: "AnyTown", State: "UT" }, 
                FirstName: "Dave", 
                LastName: "Slacker"
            }
];

var Search = React.createClass({
    render: function() {
        return (
            <div className="search">
                Search Box
            </div>
        );
    }
});

var ContactList = React.createClass({
    render: function() {
		var contactNodes = this.props.data.map(function(contact) {
			return (
					<ListItemWrapper key={contact.ContactId} data={contact} />
			)
		})
		return(
			<ul>
				{contactNodes}
			</ul>
		);
    }
});

var ListItemWrapper = React.createClass({
	render: function() {
		return <li>{this.props.data.FirstName} {this.props.data.LastName}</li>;
	}
});

var App = React.createClass({
    render: function() {
        return (
            <div className="contact-app">
                Contact App
                <Search />
                <ContactList url="/contacts" />
            </div>
        );
    }
});

React.render(
  <App />,
  document.getElementById('content')
);
