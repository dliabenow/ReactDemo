
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
				Search<input type="search" name="search" />
				<span className="glyphicon glyphicon-search" aria-hidden="true"></span>
            </div>
        );
    }
});

var ContactList = React.createClass({
  render: function() {
    var contactNodes = this.props.contacts.map(function (contact) {
      return (
        <ListItemWrapper key={contact.ContactId} FirstName={contact.FirstName} LastName={contact.LastName} />
      );
    });
    return (
      <div className="contactList">
        {contactNodes}
      </div>
    );
  }
});

var ListItemWrapper = React.createClass({
	render: function() {
		return <li className="contactItem"> {this.props.FirstName} {this.props.LastName}</li>;
	}
});

var App = React.createClass({
	render: function() {
        return (
            <div className="contact-app">
                Contact App
                <Search />
                <ContactList contacts={data} />
            </div>
        );
    }
});

React.render(
  <App contacts={data} />,
  document.getElementById('content')
);
